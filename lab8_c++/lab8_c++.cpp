
#include <iostream>

using namespace std;

int number_of_digits(int a);

int main()
{
    int (*number_of_digit)(int) = number_of_digits;
    cout << (*number_of_digit)(765);
}

int number_of_digits(int a)
{
    int number = 0;
    while (a > 0) 
    {
        a /= 10;
        number++;
    }
    return number;
}