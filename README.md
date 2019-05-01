# DC-ILR-1920


# Command used to Generate Repo Contents from another repo

## CD to folder to create clone repo in


```
mkdir CloneRepo
cd CloneRepo
git clone --bare https://sfa-gov-uk@dev.azure.com/sfa-gov-uk/DCT/_git/DC-ILR-1819
cd DC-ILR-1819.git
$ git push --mirror https://sfa-gov-uk@dev.azure.com/sfa-gov-uk/DCT/_git/DC-ILR-1920-Model
cd.. 
rmdir /s DC-ILR-1819.git
```

