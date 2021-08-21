clear
clc

inputSize=input('Please Enter Size of The Magic Square: ');
magicAmount=input('Please Enter The Magic Amount: ');
standardMagicAmount=(((inputSize^2)+1)*inputSize^2)/(2*inputSize);
magicAmount=(magicAmount-standardMagicAmount)/inputSize;
matrixBody=zeros(inputSize);
matrixBody(:,:)=nan;
if mod(inputSize,2)~=0
    disp(magicAmount+oddMagic(inputSize,matrixBody));
elseif mod(inputSize,4)==0
    cornerSquare=inputSize/4;
    middleSquare=inputSize/2;
    newBody=1:inputSize^2;
    newBody=(reshape(newBody,inputSize,inputSize))';
    %Top Left
    for i=1:cornerSquare
        for j=1:cornerSquare
            newBody(i,j)=((inputSize^2)+1)-newBody(i,j);
        end
    end
    %Top Right
    for i=1:cornerSquare
        for j=(inputSize-cornerSquare+1):inputSize
            newBody(i,j)=((inputSize^2)+1)-newBody(i,j);
        end
    end
    %Down Left
    for i=(inputSize-cornerSquare+1):inputSize
        for j=1:cornerSquare
            newBody(i,j)=((inputSize^2)+1)-newBody(i,j);
        end
    end
    %Down Right
    for i=(inputSize-cornerSquare+1):inputSize
        for j=(inputSize-cornerSquare+1):inputSize
            newBody(i,j)=((inputSize^2)+1)-newBody(i,j);
        end
    end
    %Middle
    for i=(cornerSquare+1):(cornerSquare+middleSquare)
        for j=(cornerSquare+1):(cornerSquare+middleSquare)
            newBody(i,j)=((inputSize^2)+1)-newBody(i,j);
        end
    end
    matrixBody=newBody;
    disp(magicAmount+matrixBody);
elseif mod(inputSize,4)==2
    matrixBody_help=zeros(inputSize/2);
    matrixBody_help(:,:)=nan;
    baseMagic=oddMagic(inputSize/2,matrixBody_help);
    subMagicRight=baseMagic+((inputSize/2)^2)*2;
    subMagicDown=baseMagic+((inputSize/2)^2)*3;
    subMagicDiag=baseMagic+(inputSize/2)^2;
    baseMagic=[baseMagic,subMagicRight;subMagicDown,subMagicDiag];
    %Swaps
    j=1;
    while j<=floor(inputSize/4)
        if j==1
            baseMagic([(1:floor(inputSize/4)) (((inputSize/2)+1):(floor(3*inputSize/4)))])=baseMagic([(((inputSize/2)+1):(floor(3*inputSize/4))) (1:floor(inputSize/4))]);
            baseMagic([((ceil(inputSize/4)+1):inputSize/2) ((ceil(3*inputSize/4)+1):inputSize)])=baseMagic([((ceil(3*inputSize/4)+1):inputSize) ((ceil(inputSize/4)+1):inputSize/2)]);
            j=j+1;
            continue;
        end
        baseMagic([((inputSize*(j-1)+1):(inputSize*(j-1/2))) (((inputSize*(j-1/2))+1):inputSize*j)])=baseMagic([(((inputSize*(j-1/2))+1):inputSize*j) ((inputSize*(j-1)+1):(inputSize*(j-1/2)))]);
        j=j+1;
    end
    topLeftCenter=sub2ind(size(matrixBody),ceil(inputSize/4),ceil(inputSize/4));
    downLeftCenter=sub2ind(size(matrixBody),ceil(3*inputSize/4),ceil(inputSize/4));
    baseMagic([topLeftCenter downLeftCenter])=baseMagic([downLeftCenter topLeftCenter]);
    if (floor(inputSize/4)-1)>0
        helpFinding=sub2ind(size(matrixBody),1,(inputSize-floor(inputSize/4)));
        j=1;
        while j<=(floor(inputSize/4)-1)
            baseMagic([(helpFinding+((j-1)*inputSize):(helpFinding+((j-1)*inputSize)+inputSize/2-1)) ((helpFinding+((j-1)*inputSize)+inputSize/2):(helpFinding+((j-1)*inputSize)+inputSize-1))])=baseMagic([((helpFinding+((j-1)*inputSize)+inputSize/2):(helpFinding+((j-1)*inputSize)+inputSize-1)) (helpFinding+((j-1)*inputSize):(helpFinding+((j-1)*inputSize)+inputSize/2-1))]);
            j=j+1;
        end
    end
    disp(magicAmount+baseMagic);
end