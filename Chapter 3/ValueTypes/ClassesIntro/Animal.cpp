#include "Animal.h"
#include <iostream>

// **********************************************************************
// ********************* CAnimal Implementation *************************
// **********************************************************************
CAnimal::CAnimal()
{
	m_bIsVegetarian = false;
	m_bIsHungry = true;
	m_bIsDangerous = false;

	std::cout << "Animal Default ctor" << std::endl;
}

CAnimal::CAnimal(bool bIsVegetarian)
{
	m_bIsVegetarian = bIsVegetarian;
	m_bIsHungry = true;
	m_bIsDangerous = false;

	std::cout << "ctor - Animal is vegetarian" << std::endl;
}

CAnimal::~CAnimal()
{
	std::cout << "Animal dtor" << std::endl;
}

void CAnimal::Speak()
{
	std::cout << "I cannot talk" << std::endl;
	std::cout << "I am " << (m_bIsVegetarian ? "" : "NOT ") << "a vegetarian" << std::endl;
	std::cout << "... and I am " << (m_bIsHungry ? "" : "NOT ") << "hungry" << std::endl << std::endl;
}

bool CAnimal::Feed()
{
	bool bRetVal = m_bIsHungry;
	m_bIsHungry = false;

	std::cout << "Animal  is no longer hungry" << std::endl << std::endl;

	return bRetVal;
}

// ********************************************************************
// ********************* CLion Implementation *************************
// ********************************************************************

CLion::CLion()
{
	m_bIsVegetarian = false;
	m_bIsHungry = true;
	// m_bIsDangerous = true;	// Compile error - private base class variable is inaccessible

	std::cout << "Lion Default ctor" << std::endl;
}

CLion::~CLion()
{
	std::cout << "Lion ctor" << std::endl;
}

void CLion::Speak()
{
	std::cout << "I am King of the forest <ROAR>" << std::endl;
	std::cout << "I am " << (m_bIsVegetarian ? "" : "NOT ") << "a vegetarian" << std::endl;
	std::cout << "... and I am " << (m_bIsHungry ? "" : "NOT ") << "hungry" << std::endl << std::endl;
}

bool CLion::Feed()
{
	std::cout << "I love raw meat!" << std::endl;
	return CAnimal::Feed();
}