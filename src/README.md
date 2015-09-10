..\.nuget\nuget pack

..\.nuget\nuget push LyphTEC.MongoSimpleMembership.2.0.1.nupkg -Source https://www.myget.org/F/lotosbin-public-nuget/api/v2/package

..\.nuget\nuget setapikey key -Source https://www.myget.org/F/lotosbin-public-nuget/api/v2/package 