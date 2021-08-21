function result=oddMagic(inputSize,matrixBody)
i=1; row=1;
column=ceil(inputSize/2);
matrixBody(row,column)=i;
while i<inputSize^2
    i=i+1;
    row=row-1;
    column=column+1;
    if row<1
        row=inputSize;
    end
    if column>inputSize
        column=1;
    end
    if isnan(matrixBody(row,column))==0
        row=previousRow+1;
        column=previousColumn;
        matrixBody(row,column)=i;
        continue;
    end
    previousRow=row;
    previousColumn=column;
    matrixBody(row,column)=i;
end
result=matrixBody;
end