function b=IsSafe(ChessTable,x,y)
    b=1;
    for i=1:size(ChessTable,1)
       if ChessTable(i,y)=='Q'
          b=0; 
       end
       if ChessTable(x,i)=='Q'
          b=0; 
       end
    end
    for i=1:size(ChessTable,1)
       for j=1:size(ChessTable,2)
           if abs(i-x)==abs(j-y)
              if ChessTable(i,j)=='Q'
                 b=0;
                 if i==x && j==y
                 b=1; 
                 end
              end
           end
       end
    end
end