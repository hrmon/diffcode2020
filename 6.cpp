#include <string>
#include <iostream>
using namespace std;

int main() {
    string s;
    cin >> s;
    int n, r=0;
    cin >> n;
    for (int i=0; i<n; i++) {
        string x;
        cin >> x;
        int it = 0;
        for (int j=0; j<x.size(); j++)
            if (x[j] == s[it])
                it++;
        if (it == s.size())
            r++;
    }
    cout<< r << endl;
}