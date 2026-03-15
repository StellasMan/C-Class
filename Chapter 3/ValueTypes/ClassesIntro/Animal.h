#pragma once

class CAnimal
{
public:
	CAnimal();
	CAnimal(bool bIsVegetarian);
	virtual ~CAnimal();

	virtual void Speak();
	virtual bool Feed();

protected:
	bool	m_bIsHungry;
	bool	m_bIsVegetarian;

private:
	bool	m_bIsDangerous;
};

class CLion : public CAnimal
{
public:
	CLion();
	virtual ~CLion();

	virtual void Speak();
	virtual bool Feed();

protected:

private:
};

