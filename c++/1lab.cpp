#include <iostream>

using namespace std;

void Increment(int &x);
bool Comparison(int a, int b);

int main(){
	int x = 63;
	int a = 2,b = 1;
	Increment(x);
	cout << x << endl;
	cout << Comparison(a,b);
}

void Increment(int &x){
	int m = 1; 
	while (x & m)
	{
		x &= ~m;
		m <<= 1;
	}
	x |= m;
}

bool Comparison(int a, int b){
	int m = 1, i = 0;
        while ((a & m) == (b & m) && i < 32)
           {
            a &= ~m;
            b &= ~m;
            m <<= 1;
            if(a == 0)
           {
                if (b == 0) return true;
                else return false;
           }
           i++;
    	}
    return false;
}


