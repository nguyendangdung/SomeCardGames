#pragma once

#include "Card.h"
#include "EnumCardState.h"

#include <algorithm>
#include <chrono>
#include <random>
#include <vector>

using namespace std;

/// <summary>
/// Used to represent a deck of cards.
/// </summary>
class Deck
{
public:

	/// <summary>
	/// The constructor for the Deck class.
	/// </summary>
	Deck();

	/// <summary>
	/// The deconstructor for the Deck class. 
	/// </summary>
	~Deck();

	/// <summary>
	/// Holds all of the cards in this deck.
	/// </summary>
	vector<Card*> *AllCards = new vector<Card*>();

	/// <summary>
	/// Used to shuffle the deck of cards.
	/// </summary>
	void Shuffle();

	int GetRandomNumber(int Max);
};