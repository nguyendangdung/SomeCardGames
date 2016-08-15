#include "stdafx.h"

#include "Card.h"
#include "EnumCards.h"
#include "EnumCardState.h"
#include "EnumSuit.h"

using namespace std;

Card::Card(int WhatCard, int CardState)
{
	this->WhatCard = WhatCard;
	this->FigureOutSuit(WhatCard);
}


Card::~Card()
{
	delete this->Cards;
	delete this->CardStates;
	delete this->Suits;
}

void Card::FigureOutSuit(int WhatCard)
{
	if (WhatCard <= 12)
	{
		this->WhatSuit = this->Suits->Hearts;
		return;
	}

	if (WhatCard >= 13 && WhatCard <= 25)
	{
		this->WhatSuit = this->Suits->Diamonds;
		return;
	}

	if (WhatCard >= 26 && WhatCard <= 38)
	{
		this->WhatSuit = this->Suits->Spades;
		return;
	}

	//This may need to change, if joker support is added.
	if (WhatCard >= 39)
	{
		this->WhatSuit = this->Suits->Clubs;
		return;
	}

	try
	{
		Errors->ThrowException(Errors->ErrorValueOutOfAcceptableRange);
	}
	catch (exception e)
	{
		//Do something here, once we have a logging system
	}
}