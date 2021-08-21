function flag=findway(details,startingpoint,previous,current)
flag=[];
[row,~]=find(details(:,1:2)==current);
next=setdiff(details(row,1:2),current);
next_help=next;
next=setdiff(next,previous);
if isempty(next)==1
    if isempty(find(next_help==startingpoint, 1))==1
       return;
    else
        [row1,~]=find(details(:,1:2)==startingpoint);
        [row2,~]=find(details(:,1:2)==current);
        flag=details(intersect(row1,row2),3);
    end
end
for i=1:size(next,1)
    previous=unique([previous,current]);
    [row3,~]=find(details(:,1:2)==next(i,1));
    [row4,~]=find(details(:,1:2)==current);
    flag=[flag;findway(details,startingpoint,previous,next(i,1))+details(intersect(row3,row4),3)];
end
end