# votingtoolmock

This repo had automatic deploy set up. Any commits will be reflected at the endpoint within a few minutes.

```
https://votingtoolmock.azurewebsites.net/api/bogus/candidates
```

```
https://votingtoolmock.azurewebsites.net/api/bogus/election
```

#Candidates:
```json
[
  {
    "candidateId": 1,
    "firstName": "Mike",
    "lastName": "Hansen",
    "picture": "https://vancouver.ca/plan-your-vote/img/mayor1.jpg",
    "organization": ""
  },
  {
    "candidateId": 2,
    "firstName": "John",
    "lastName": "Yano",
    "picture": "https://vancouver.ca/plan-your-vote/img/mayor2.jpg",
    "organization": ""
  },
  {
    "candidateId": 3,
    "firstName": "David",
    "lastName": "Chen",
    "picture": "https://vancouver.ca/plan-your-vote/img/mayor3.jpg",
    "organization": "ProVancouver"
  }
]
```

#Election
```
{
  "VoteTitle": "B.C. Provincial Election",
  "VoteDescription": "Elect members of the Legislative Assembly in the province of British Columbia",
  "VoteDate": "",
  "PageBackgroundColor": "#FFFFFF",
  "PageBackgroundColorSecondary": "#E60050",
  "PageTextColor": "#000000",
  "LogoURL": "https://vancouver.ca/images/cov/feature/covlogo-share.png",
  "PageFontSize": "1.5em",
  "PageFontFamily": "Helvetica"
}```
