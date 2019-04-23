#pragma once
#include "pch.h"
#include <iostream>
using namespace std;

class createi {

protected:

public:
	createi();

};

createi::createi(){

	cout << "\t\t\tHi!!" << endl;
	cout << "\t\tThank you for running me." << endl;
	cout << "\t\t\tAre you Krystal?" << endl;
}

class createl : createi {

protected:

public:


};

class createy : createi, createl {

protected:

public:


};