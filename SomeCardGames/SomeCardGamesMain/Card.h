#pragma once

/// <summary>
/// Represents a card in game.
/// </summary>
class Card
{
public:
	/// <summary>
	/// Used to figure out what card this is.
	/// </summary>
	EnumCards *Cards;

	/// <summary>
	/// Used to figure out if the card is face up, face down, or out of the game.
	/// </summary>
	EnumCardState *CardStates;

	/// <summary>
	/// Used to figure out what suit this card is.
	/// </summary>
	EnumSuit *Suits;

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
	Card(int WhatCard);

	/// <summary>
	/// The deconstructor for the Card class.
	/// </summary>
	~Card();

	/// <summary>
	/// This method is used to set what suit this card is.
	/// </summary>
	/// <param name="WhatCard"></param>
	void FigureOutSuit(int WhatCard);

private:


};