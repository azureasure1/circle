/*
Programmer: Cody Griffin
Date: 3/31/2016
*/

#include <iostream>

using namespace std;

int main(){
	//Variables
	const double pi = 3.14;
	int radius;
	double circumference;
	double area;
	
	//Asks what radius the user would like on his or her circle
	cout << "What is the radius of your circle? ";
	cin >> radius;
	cout << endl;
	
	circumference = pi * (2 * radius);
	area = pi * (radius * radius);
	
	cout << "This is your radius: " << radius << endl;
	cout << "This is the circumference of the circle: " << circumference << endl;
	cout << "This is the area of the circle: " << area << endl;
	
	cin.ignore();
	cin.get();
	return 0;
}