// ClassesIntro.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include "Animal.h"

#include <iostream>

void Example1()
{
	CAnimal		cAnimal1;						// Uses default constructor - NOT a vegetarian
	CAnimal*	pcAnimal2 = new CAnimal(true);	// 'pcAnimal2' IS a vegetarian

	cAnimal1.Speak();
	pcAnimal2->Speak();

	cAnimal1.Feed();
	cAnimal1.Speak();
	pcAnimal2->Speak();

	// delete pcAnimal2;
}

void Example2()
{
	CAnimal	* pcAnimal = (CAnimal*)new CLion();

	pcAnimal->Speak();
	pcAnimal->Feed();
	pcAnimal->Speak();

	delete pcAnimal;
}

int main()
{
	Example1();
	std::getchar();

	Example2();
	std::getchar();
}
