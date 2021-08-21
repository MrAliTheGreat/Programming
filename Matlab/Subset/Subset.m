clear
clc

set=input('Please Enter Your Set: ');
sizeSet=size(set,2);
subsetBody=zeros(1,sizeSet);
output=findSubset(subsetBody);
sizeOutput=size(output,1);
disp('Perms: ');
disp(output);
disp('Subsets: ');
output=logical(output);
for i=1:sizeOutput
    disp(set(output(i,:)));
end
disp('Number of Subsets: ');
disp(sizeOutput);