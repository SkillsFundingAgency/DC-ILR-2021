# DC-ILR-2021


# Command used to Generate Repo Contents from another repo

## CD to folder to create clone repo in


```
mkdir CloneRepo
cd CloneRepo
git clone --bare https://sfa-gov-uk@dev.azure.com/sfa-gov-uk/DCT/_git/DC-ILR-1920
cd DC-ILR-1920.git
$ git push --mirror https://sfa-gov-uk@dev.azure.com/sfa-gov-uk/DCT/_git/DC-ILR-2021-Model
cd.. 
rmdir /s DC-ILR-1920.git
```

