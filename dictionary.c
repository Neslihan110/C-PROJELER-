#include <stdbool.h>
#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include <string.h>
#include "dictionary.h"

typedef struct dugum
{
    char word[LENGTH+1];
    struct dugum* next;
}
dugum;
dugum* hash_tablosu[26];
int hash_function(const char* word)
{
    return word[0] - 'a';

}
int dugum_sayisi = 0;
bool check(const char* word)

{
    char temp_word[LENGTH+1] = {'\0'};

    strcpy(temp_word, word);

    for(int i = 0; word[i] != '\0'; i++)

        temp_word[i] = tolower(word[i]);

    int temp_array = hash_function(temp_word);
    dugum* temp_dugum = hash_tablosu[temp_array];
    while(temp_dugum != NULL)
    {
        if(strcmp(temp_word, temp_dugum->word) == 0)

            return true;
        temp_dugum = temp_dugum->next;
    }
    return false;
}
bool load(const char* dictionary)
{
    FILE* fp = fopen(dictionary, "r");
    if(dictionary == NULL)
        return false;

    char* string = malloc(sizeof(char)*(LENGTH+1));   
    while (fscanf(fp, "%s", string) != EOF)
    {
        dugum* new_dugum = malloc(sizeof(dugum));

        strcpy(new_dugum->word, string);
        int hash_number = hash_function(string);

        new_dugum->next = hash_tablosu[hash_number];
        hash_tablosu[hash_number] = new_dugum;

        dugum_sayisi++;
    }
    free(string);
    fclose(fp);
    return true;
}
unsigned int size(void)
{
    if(dugum_sayisi != 0)

        return dugum_sayisi;            
    return 0;
}

bool unload(void)
{
    for(int i=0; i<27; i++)

    {
     dugum* temp_dugum_1 = hash_tablosu[i];
        while(temp_dugum_1 != NULL)

        {
            dugum* temp_dugum_2 = temp_dugum_1->next;

            free(temp_dugum_1);
            temp_dugum_1 = temp_dugum_2;
        }
    }
    return true;
}
