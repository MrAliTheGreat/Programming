clear
clc
a=input('What is the size of your chess board? ');
global ways
ways=0;
PlaceQueens(zeros(a,a),1)
clear ans
disp(['There are ',num2str(ways),' ways to place the queens.'])