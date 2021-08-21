function a=PlaceQueens(ChessTable,row)
global ways
    if row>size(ChessTable,1)
       a=0;
       disp(ChessTable);
       ways=ways+1;
       return;
    end
    for j=1:size(ChessTable,2)
       if IsSafe(ChessTable,row,j)==1
          ChessTable(row,j)='Q';
          if PlaceQueens(ChessTable,row+1)==0
              ChessTable(row,j)=0;
          end
       end
       a=0;
    end
end