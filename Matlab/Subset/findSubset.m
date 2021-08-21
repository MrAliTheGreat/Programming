function flag=findSubset(set)
flag=[];
zeroPlaces=find(set==0);
onePlaces=find(set==1);
if isempty(onePlaces)==0
    zeroPlaces=zeroPlaces(zeroPlaces>onePlaces(end));
end
for i=1:size(zeroPlaces,2)
    setHelp=set;
    set(1,zeroPlaces(1,i))=1;
    flag=[flag;findSubset(set)];
    set=setHelp;
end
flag=[flag;set];
end