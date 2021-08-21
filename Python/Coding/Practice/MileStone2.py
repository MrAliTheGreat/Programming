from random import shuffle
from random import randint


class Player():

	def __init__(self,money=100):
		self.money=money
		self.player_cards=[]


	def place_bet(self,bet):
		flag_bet=False
		if bet <= self.money:
			print(f'You have bet {bet}$')
			self.money-=bet
			flag_bet=True
		else:
			print("You don't have enough money bet lower!")
		return flag_bet


	def win_prize(self,prize):
		self.money+=prize
		print(f'Congrats! You won {prize}$')


	def show_remaining_money(self):
		print(f'You have {self.money}$ left!')


	def hit(self,deck):
		random_index=randint(0,len(deck)-1)
		ace=[1,11]
		if deck[random_index]==1 or deck[random_index]==11:
			choice=int(input('You Have Gotten an ACE!\nWhich one do you want as your ace 1 or 11? '))
			self.player_cards.append(choice)
			ace.remove(choice)
			deck.remove(choice)
			deck.remove(ace[0])
		else:
			self.player_cards.append(deck[random_index])

		return deck


	def sum_cards(self):
		return sum(self.player_cards)


	def __str__(self):

		return str(self.player_cards)


class Cards():

	def __init__(self):
		
		self.cards=list(range(2,11))*4
		for item in ['Jack','King','Queen']:
			self.cards.append(10)
		for item in ['Spades', 'Hearts', 'Diamonds', 'Clubs']:
			self.cards.append(1)
			self.cards.append(11)


	def shuffle_cards(self):
		shuffle(self.cards)
		return self.cards


	def __str__(self):
		return str(self.cards)


class Dealer():

	def __init__(self):
		self.dealer_cards=[]
		self.random_index_dealer=randint(0,1)


	def hit(self,deck):
		random_index=randint(0,len(deck)-1)
		random_index_choice=randint(0,1)
		ace=[1,11]
		if deck[random_index]==1 or deck[random_index]==11:
			self.dealer_cards.append(ace[random_index_choice])
			deck.remove(ace[random_index_choice])
			ace.remove(ace[random_index_choice])
			deck.remove(ace[0])
		else:
			self.dealer_cards.append(deck[random_index])

		return deck


	def sum_cards(self):
		return sum(self.dealer_cards)


	def show_all_hand(self):
		print(self.dealer_cards)	


	def __str__(self):
		return str(self.dealer_cards[self.random_index_dealer])





if __name__ == '__main__':

	flag_game=True

	while True:
		flag=True

		cards=Cards()
		print('Unshuffled Cards!')
		print(cards)
		cards=cards.shuffle_cards()
		print('Shuffled Cards!')
		print(cards)


		new_player=Player() # Money is 100 by default
		# Receiving first 2 cards for player
		cards=new_player.hit(cards)
		cards=new_player.hit(cards)

		print('Player Cards!')
		print(new_player)

		new_dealer=Dealer()
		# Receiving first 2 cards for dealer
		cards=new_dealer.hit(cards)
		cards=new_dealer.hit(cards)

		print('Dealer Cards only 1!')
		print(new_dealer)

		# Placing bet
		while True:
			try:
				bet_player=int(input('How much do you want to bet? '))
			except:
				print('Your input is NOT valid please enter a new input!\n')
			else:
				break

		flag_bet_main=new_player.place_bet(bet_player)
		while True:
			if not flag_bet_main:
				bet_player=int(input('How much do you want to bet? '))
				flag_bet_main=new_player.place_bet(bet_player)
			else:
				break

		# For Player
		while flag:

			choice_game=input('Do you want to Hit or Stay? ').lower()

			if choice_game=='hit':
				cards=new_player.hit(cards)
				print('Player Cards!')
				print(new_player)
				print(f'Sum of your cards is: {new_player.sum_cards()}')
				if new_player.sum_cards()>21:
					print('Computer Won!')
					print('Computer Cards Were:')
					new_dealer.show_all_hand()
					flag_game=False
					flag=False

			elif choice_game=='stay':
				flag=False

		if not flag_game:
			break


		# For Dealer
		while new_dealer.sum_cards()<=21:
			if new_dealer.sum_cards()>new_player.sum_cards() and new_dealer.sum_cards()<=21:
				flag_game=False
				break
			cards=new_dealer.hit(cards)
			
		if flag_game:
			print('You Won!')
			new_player.win_prize(bet_player*2)
			new_player.show_remaining_money()
			print('Computer Cards Were:')
			new_dealer.show_all_hand()
			break
		else:
			print('Computer Won!')
			print('Computer Cards Were:')
			new_dealer.show_all_hand()
			break

	