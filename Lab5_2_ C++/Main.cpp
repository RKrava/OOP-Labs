#include <iostream>
#include "Figures.h"
#include "Circle.h"
#include "Elips.h"
using namespace std;

int main() {
    Elips elips(2, 3);
    Circle circle(4);
    cout << elips.Length() << "\n";
    cout << elips.Square() << "\n";
    cout << circle.Length() << "\n";
    cout << circle.Square() << "\n";
}