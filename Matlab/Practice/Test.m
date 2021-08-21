clear
clc
%Testing echo
echo on

a=input('a= ');
b=2;
c=3;
d=execution(b,c)/a;
disp(d);
%% 
%Deteming the speed of linspace & the normal one
clear
clc

tic
a=linspace(0,10,11);
toc
tic
b=[0:1:10];
toc
tic
c=[linspace(0,10,11)];
toc
tic
d=(linspace(0,10,11));
toc
%%
clear
clc
%Difference between a' & a.'

a=[1+2i,2+3i,3+4i];
b=(1:3);
disp(a');
disp(a.');
disp(b');
disp(b.');
%%
%Different Ways Different Speeds
clear 
clc

a=5;
tic
b=a*ones(3,3);
toc
tic
c=a+zeros(3,3);
toc
tic
d=a(ones(3,3));
toc
tic
e=repmat(a,3,3);
toc

%%
clear
clc

student.name='Ali Bahari';
student.score=17.51;
student.education=1;
disp(execution(student));

%%
clear
clc

for i=1:5
    a=i*2;
    if i==3
       continue 
    end
    disp(a);
end

%%
clear
clc

