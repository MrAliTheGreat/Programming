#include <cstdlib>
#include <iostream>
#include <string>
#include <vector>
#include <sstream>
#include <numeric>
#include <ctime>
#include <algorithm>

using namespace std;

string Vector2String(vector<string> vec_names , char connector);

int main(int argc, char** argv) {
    double j = -((double)8/5);
    cout << j << endl;
}

string Vector2String(vector<string> vec_names , char connector){
    string myString = "";
    for(auto name : vec_names){
        myString += name + connector;
    }
    return myString;
}