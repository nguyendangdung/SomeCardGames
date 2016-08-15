#pragma once

#include "EnumCards.h"
#include "EnumCardState.h"
#include "EnumSuit.h"

using namespace std;

/// <summary>
/// Represents a card in game.
/// </summary>
class PROJECTAPI Card
{
public:
	/// <summary>
	/// Used to figure out what card this is.
	/// </summary>
	EnumCards *Cards = new EnumCards();

	/// <summary>
	/// Used to figure out if the card is face up, face down, or out of the game.
	/// </summary>
	EnumCardState *CardStates = new EnumCardState();

	/// <summary>
	/// Used to figure out what suit this card is.
	/// </summary>
	EnumSuit *Suits = new EnumSuit();

	/// <summary>
	/// What card this is.
	/// </summary>
	int WhatCard;

	/// <summary>
	/// If the card is face up, face down, or out of the game.
	/// </summary>
	int WhatCardState;

	/// <summary>
	/// What suit this card is.
	/// </summary>
	int WhatSuit;

	/// <summary>
	/// The constructor for the Card class.
	/// </summary>
	Card(int WhatCard, int CardState);

	/// <summary>
	/// The deconstructor for the Card class.
	/// </summary>
	~Card();

	/// <summary>
	/// This method is used to set what suit this card is.
	/// </summary>
	/// <param name="WhatCard"></param>
	void FigureOutSuit(int WhatCard);
};