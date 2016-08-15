#include "stdafx.h"

#include "Deck.h"

Deck::Deck()
{
	EnumCardState state;
	int i = 0;

	while (i != 54)
	{
		Card *TheCard = new Card(i, state.FaceDown);
		this->AllCards->push_back(TheCard);
		
		i++;
		delete TheCard;
	}

	this->Shuffle();
}


Deck::~Deck()
{
}

void Deck::Shuffle()
{
	random_shuffle(this->AllCards->begin(), this->AllCards->end());
}

int Deck::GetRandomNumber(int Max)
{
	srand(time(0));  // needed once per program run
	return rand() % Max + 1;
}