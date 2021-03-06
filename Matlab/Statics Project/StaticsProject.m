%Code By: Ali Bahari - Behnam Akhlaghi
clear
close all
clc

%Get The Information From Excel File

BeamMatrix = xlsread('BeamDetails.xlsx') ; 

%Finding The Number Unknowns

Unknowns  = 0 ;

for i=1:BeamMatrix(1,2)
    Flag = 2 ;
    if i == 1 || i == BeamMatrix(1,2)
        Flag = 1;
    end
    for j = 1:6
        if j > 3
            Flag = 1;
        end
        Unknowns = Unknowns + BeamMatrix(i+2,j+3)*Flag;
    end
end

%Finding The Number of Equations

Equations = (BeamMatrix(1,2)*2 - 1 )*3;

for i=1:BeamMatrix(1,2)
    for j = 1:3
        if BeamMatrix(i+2,j+3) == 0
            Equations = Equations -  1;
        end
    end
end

%Determining The Certainty of The structure (Moayan)   
%Shows The Result in Command Window
if Unknowns ~= Equations 
   disp('Uncertain (Na Moayan)');
   return
end

FirstMatrix = zeros(Unknowns) ;
SecondMatrix = zeros(Unknowns,1);

%Making FirstMatrix Just For Joints 

Counter = 0 ;

for i=1:BeamMatrix(1,2)
    Flag = 2 ;   
    if i == 1 || i == BeamMatrix(1,2)
        Flag = 1;
    end
    for j = 1:3
        if BeamMatrix(i+2,j+3) ~= 0
            Counter = Counter + 1;
            FirstMatrix(Counter,FindPlace(i+2,j+3,BeamMatrix)) = 1 ;
            if Flag == 2
                FirstMatrix(Counter,FindPlace(i+2,j+3,BeamMatrix)-1) = 1;
            end
            if BeamMatrix(i+2,j+6) == 1
                FirstMatrix(Counter,FindPlace(i+2,j+6,BeamMatrix)) = 1 ;
            end
        end
    end
end

%Making FirstMatrix Just For Elements

for i=1:BeamMatrix(1,15)
    for j = 1:3
        % BeamMatrix(2+*,15) Left Joint
        % BeamMatrix(3+*,16) Right Joint
        
        Counter = Counter +1 ;
        
        if BeamMatrix(BeamMatrix(i+2,15)+2,j+3) == 1
            FirstMatrix(Counter,FindPlace(BeamMatrix(i+2,15)+2,j+3,BeamMatrix)) = -1;
        end
        
        if BeamMatrix(BeamMatrix(i+2,16)+2,j+3) == 1
            % For The Last Joint
            
            if BeamMatrix(i+2,16) ~=BeamMatrix(1,2)
                FirstMatrix(Counter,FindPlace(BeamMatrix(i+2,16)+2,j+3,BeamMatrix)-1) = -1;
            else
                FirstMatrix(Counter,FindPlace(BeamMatrix(i+2,16)+2,j+3,BeamMatrix)) = -1;
            end
            
        end
        
        %Finding Moment With Respect To left Point (Langar Hol Noghteye Chap Eleman)
        if j == 3
            % For The Last Joint
            if BeamMatrix(i+2,16) ~=BeamMatrix(1,2)
                %Finding Moment With Respect To X axis (Langar dar rastaye X)
                FirstMatrix(Counter,FindPlace(BeamMatrix(i+2,16)+2,j+1,BeamMatrix)-1) = (BeamMatrix(BeamMatrix(i+2,16)+2,3)-BeamMatrix(BeamMatrix(i+2,15)+2,3)) ;
                %Finding Moment With Respect To Y axis (Langar dar rastaye Y)
                FirstMatrix(Counter,FindPlace(BeamMatrix(i+2,16)+2,j+2,BeamMatrix)-1) = (BeamMatrix(BeamMatrix(i+2,16)+2,2)-BeamMatrix(BeamMatrix(i+2,15)+2,2))*(-1) ;
            else
                
                FirstMatrix(Counter,FindPlace(BeamMatrix(i+2,16)+2,j+1,BeamMatrix)) = (BeamMatrix(BeamMatrix(i+2,16)+2,3)-BeamMatrix(BeamMatrix(i+2,15)+2,3)) ;
                
                FirstMatrix(Counter,FindPlace(BeamMatrix(i+2,16)+2,j+2,BeamMatrix)) = (BeamMatrix(BeamMatrix(i+2,16)+2,2)-BeamMatrix(BeamMatrix(i+2,15)+2,2))*(-1) ;
            end
        end
    end
end

%Determining Stability of The Structure (Na Paydar)
%Shows The Result in Command Window
if det(FirstMatrix) == 0 
    disp('Unstable');
    return
end

%Making SecondMatrix Just for Joints 
Counter = 0 ; 
for i=1:BeamMatrix(1,2) 
    for j = 1:3 
        if BeamMatrix(i+2,j+3) ~= 0
            Counter = Counter + 1;
            SecondMatrix(Counter,1) = (-1)*BeamMatrix(i+2,j+9) ;
        end
    end
end

%Making SecondMatrix Just for Elements
for i=1:BeamMatrix(1,15) 
    for j = 1:3 
        Counter = Counter +1 ;
        SecondMatrix(Counter,1) =(-1)* BeamMatrix(i+2,j+16)* sqrt((BeamMatrix(BeamMatrix(i+2,16)+2,3)-BeamMatrix(BeamMatrix(i+2,15)+2,3))^2 + (BeamMatrix(BeamMatrix(i+2,16)+2,2)-BeamMatrix(BeamMatrix(i+2,15)+2,2)) ^2 );
        %Moment 
        if j == 3 
        SecondMatrix(Counter,1) = SecondMatrix(Counter,1) + BeamMatrix(i+2,j+14)* sqrt((BeamMatrix(BeamMatrix(i+2,16)+2,3)-BeamMatrix(BeamMatrix(i+2,15)+2,3))^2 + (BeamMatrix(BeamMatrix(i+2,16)+2,2)-BeamMatrix(BeamMatrix(i+2,15)+2,2)) ^2)*(BeamMatrix(BeamMatrix(i+2,16)+2,3)-BeamMatrix(BeamMatrix(i+2,15)+2,3))/2 -  BeamMatrix(i+2,j+15)* sqrt((BeamMatrix(BeamMatrix(i+2,16)+2,3)-BeamMatrix(BeamMatrix(i+2,15)+2,3))^2 + (BeamMatrix(BeamMatrix(i+2,16)+2,2)-BeamMatrix(BeamMatrix(i+2,15)+2,2)) ^2)*(BeamMatrix(BeamMatrix(i+2,16)+2,2)-BeamMatrix(BeamMatrix(i+2,15)+2,2))/2;
        end
    end
end
Answers = FirstMatrix\SecondMatrix;

%Creating The Answers Matrix Suitable For Excel
ExcelMatrix=zeros(BeamMatrix(1,2),9);
k=1;

for i=1:BeamMatrix(1,2)
    if i==1 || i==BeamMatrix(1,2)
        for j=1:6
            if mod(j,2)~=0
                ExcelMatrix(i,j)=Answers(k,1);
                k=k+1;
            end
        end
        for j=7:9
            if BeamMatrix(i+2,j)==1
                ExcelMatrix(i,j)=Answers(k,1);
                k=k+1;
            end
        end
     else
        for j=1:2:5
            if BeamMatrix(i+2,(j+7)/2)==1
                ExcelMatrix(i,j)=Answers(k,1);
                ExcelMatrix(i,j+1)=Answers(k+1,1);
                k=k+2;
            else
                ExcelMatrix(i,j)=0;
                ExcelMatrix(i,j+1)=0;
            end
        end
        for j=7:9
            if BeamMatrix(i+2,j)==1
                ExcelMatrix(i,j)=Answers(k,1);
                k=k+1;
            end
        end
    end
end

%Print The Answers Matrix In Excel

ExcelMatrix=[[1:BeamMatrix(1,2)]',ExcelMatrix];
xlrange=strcat('A19',':J',num2str(18+BeamMatrix(1,2)));
xlswrite('BeamDetails.xlsx',ExcelMatrix,xlrange);

