	#include <stdio.h>

	int main() {

    // We can use the printf command to format a string together with other strings, in the following manner:

	char * name = "John Smith";
    int age = 27;

    /* prints out 'John Smith is 27 years old.' */
    printf("%s is %d years old.\n", name, age);

    //Notice that when printing strings, we must add a newline (\n) character so that our next printf statement will print in a new line.

    //---- 


    //char * name = "Nikhil";
    // printf("%d\n",strlen(name));
    //The function 'strlen' returns the length of the string which has to be passed as an argument: 


    //char * name = "John";

    //if (strncmp(name, "Joke", 4) == 2) {
    //printf("Hello, John!\n");
    //  }   else {
    //printf("You are not John. Go away.\n");
    //}   
    
    //The function strncmp compares between two strings, returning the number 0 if they are equal, or a different number if they are different. The arguments are the two strings to be compared, and the maximum comparison length. There is also an unsafe version of this function called strcmp, but it is not recommended to use it. For example:  




    }