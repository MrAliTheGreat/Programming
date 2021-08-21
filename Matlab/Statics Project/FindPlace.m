function Number = FindPlace(x,y,Matrix)

%This Function Finds The Position of Unknowns In FirstMatrix

Number  = 0 ;
for i=1:Matrix(1,2)
    Flag = 2 ;
    if i==1 || i == Matrix(1,2)
        Flag = 1;
    end
    for j = 1:6
        if j > 3
            Flag = 1;
        end
        if i+2 < x
            Number = Number + Matrix(i+2,j+3)*Flag;
        else
            if i+2 == x && j+3 <= y
                Number = Number + Matrix(i+2,j+3)*Flag;
            end
        end
        
    end
end
end

