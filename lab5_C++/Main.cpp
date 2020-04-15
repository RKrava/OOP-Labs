#include <iostream>
#include "LetterStrings.h";
#include "Strings.h";
using namespace std;

int main()
{
    LetterStrings ltstr = LetterStrings("dafasdasd");
    cout << ltstr.GetStr() << "\n";
    ltstr.Sort();
    cout << ltstr.GetStr() << "\n";
    cout << ltstr.GetLength() << "\n";
}