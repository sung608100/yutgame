#include "player.h"
#include "Dice.h"
#include <iostream>
#include <ctime>
#include <random>

using namespace std;

void player_order(player p1, player p2)
{
	printf("���� ���ϱ� �� ���� �ֻ����� ���� �������\n");
	printf("player1 throw\n");
	//��ư�� ���� �ֻ��� ������
	srand(time(NULL));
	int dice1 = rand() % 6 + 1;
	printf("player1 dice : %d\n", dice1);

	printf("player2 throw\n");
	//��ư�� ���� �ֻ��� ������
	int dice2 = rand() % 6 + 1;
	printf("player2 dice : %d\n", dice2);
	if (dice1 > dice2) {
		p1.set_order(1);
		p2.set_order(2);
	}
	else {
		p1.set_order(2);
		p2.set_order(1);
	}
}

bool player_win(player p1, player p2)
{
	if (p1.get_order() == 1)
	{

	}
	else
	{

	}
	
}