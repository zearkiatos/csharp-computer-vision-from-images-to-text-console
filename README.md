# Description
This is a C# 🟪 console project to extract text 📄 from images 🏞️ using Azure Computer Vision 👁️🤖

# Made with
[![C#](https://img.shields.io/badge/c%23-8c39ac?style=for-the-badge&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz4KPHN2ZyBpZD0iTGF5ZXJfMSIgZGF0YS1uYW1lPSJMYXllciAxIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZlcnNpb249IjEuMSIgdmlld0JveD0iMCAwIDIyMjIgMjUwMCI+CiAgPGRlZnM+CiAgICA8c3R5bGU+CiAgICAgIC5jbHMtMSB7CiAgICAgICAgZmlsbDogIzMzMzsKICAgICAgfQoKICAgICAgLmNscy0xLCAuY2xzLTIsIC5jbHMtMywgLmNscy00IHsKICAgICAgICBzdHJva2Utd2lkdGg6IDBweDsKICAgICAgfQoKICAgICAgLmNscy0yIHsKICAgICAgICBmaWxsOiAjNjY2OwogICAgICB9CgogICAgICAuY2xzLTMgewogICAgICAgIGZpbGw6ICMwMDA7CiAgICAgIH0KCiAgICAgIC5jbHMtNCB7CiAgICAgICAgZmlsbDogI2ZmZjsKICAgICAgfQogICAgPC9zdHlsZT4KICA8L2RlZnM+CiAgPHBhdGggY2xhc3M9ImNscy0yIiBkPSJNMjIxMi4xLDc0MC4xYzAtNDEuNi04LjktNzguNC0yNi45LTExMC0xNy43LTMxLTQ0LjItNTcuMS03OS43LTc3LjYtMjkzLjItMTY5LjEtNTg2LjctMzM3LjYtODc5LjgtNTA2LjktNzktNDUuNi0xNTUuNi00My45LTIzNC4xLDIuMy0xMTYuNyw2OC44LTcwMSw0MDMuNi04NzUuMSw1MDQuNC03MS43LDQxLjUtMTA2LjYsMTA1LTEwNi42LDE4Ny42LS4xLDM0MCwwLDY4MC0uMSwxMDIwLDAsNDAuNyw4LjUsNzYuOCwyNS43LDEwNy45LDE3LjcsMzIsNDQuNSw1OC43LDgwLjksNzkuNywxNzQuMSwxMDAuOSw3NTguNSw0MzUuNiw4NzUuMiw1MDQuNCw3OC41LDQ2LjMsMTU1LjEsNDgsMjM0LjEsMi4zLDI5My4xLTE2OS4yLDU4Ni42LTMzNy44LDg3OS45LTUwNi45LDM2LjMtMjEsNjMuMi00Ny44LDgwLjktNzkuNywxNy4yLTMxLjEsMjUuNy02Ny4yLDI1LjctMTA3LjksMCwwLDAtNjc5LjgtLjEtMTAxOS44Ii8+CiAgPHBhdGggY2xhc3M9ImNscy0zIiBkPSJNMTExNC40LDEyNDYuN0wzNS41LDE4NjcuOWMxNy43LDMyLDQ0LjUsNTguNyw4MC45LDc5LjcsMTc0LjEsMTAwLjksNzU4LjUsNDM1LjYsODc1LjIsNTA0LjQsNzguNSw0Ni4zLDE1NS4xLDQ4LDIzNC4xLDIuMywyOTMuMS0xNjkuMiw1ODYuNi0zMzcuOCw4NzkuOS01MDYuOSwzNi4zLTIxLDYzLjItNDcuOCw4MC45LTc5LjdsLTEwNzIuMS02MjEuMWgwWiIvPgogIDxwYXRoIGNsYXNzPSJjbHMtMSIgZD0iTTIyMTIuMSw3NDAuMWMwLTQxLjYtOC45LTc4LjQtMjYuOS0xMTBsLTEwNzAuOCw2MTYuNiwxMDcyLjEsNjIxLjFjMTcuMi0zMS4xLDI1LjctNjcuMiwyNS43LTEwNy45LDAsMCwwLTY3OS44LS4xLTEwMTkuOCIvPgogIDxnPgogICAgPHBhdGggY2xhc3M9ImNscy00IiBkPSJNMTc0OS42LDEwMTQuNXYxMTYuMWgxMTYuMXYtMTE2LjFoNTguMXYxMTYuMWgxMTYuMXY1OC4xaC0xMTYuMXYxMTYuMWgxMTYuMXY1OC4xaC0xMTYuMXYxMTYuMWgtNTguMXYtMTE2LjFoLTExNi4xdjExNi4xaC01OC4xdi0xMTYuMWgtMTE2LjF2LTU4LjFoMTE2LjF2LTExNi4xaC0xMTYuMXYtNTguMWgxMTYuMXYtMTE2LjFoNTguMVpNMTg2NS43LDExODguNmgtMTE2LjF2MTE2LjFoMTE2LjF2LTExNi4xWiIvPgogICAgPHBhdGggY2xhc3M9ImNscy00IiBkPSJNMTExNi43LDQzMS4zYzMwMi45LDAsNTY3LjMsMTY0LjUsNzA4LjksNDA5bC0xLjQtMi40LTM1Ni4zLDIwNS4yYy03MC4yLTExOC45LTE5OC45LTE5OS4xLTM0Ni41LTIwMC43aC00LjdjLTIyNS4xLDAtNDA3LjYsMTgyLjUtNDA3LjYsNDA3LjZzMTguNSwxNDAuNyw1My44LDIwMi4zYzcwLjMsMTIyLjcsMjAyLjQsMjA1LjQsMzUzLjksMjA1LjRzMjg1LjMtODMuOCwzNTUuMi0yMDcuOGwtMS43LDMsMzU1LjgsMjA2LjFjLTE0MC4xLDI0Mi40LTQwMC45LDQwNi40LTcwMC4yLDQwOS42aC05LjFjLTMwMy44LDAtNTY5LTE2NS40LTcxMC4yLTQxMS4yLTY5LTEyMC0xMDguNC0yNTkuMS0xMDguNC00MDcuNCwwLTQ1Mi4xLDM2Ni41LTgxOC43LDgxOC43LTgxOC43aC0uMloiLz4KICA8L2c+Cjwvc3ZnPg==&logoColor=white&labelColor=000000)]()
[![NetCore & Net Framework](https://img.shields.io/badge/netcore%20&%20NET%20Framework-4f3ac9?style=for-the-badge&logo=dotnet&logoColor=white&labelColor=000000)]()
[![Azure](https://img.shields.io/badge/Azure-2b83cb?style=for-the-badge&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz4KPHN2ZyBpZD0iTGF5ZXJfMSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiB2ZXJzaW9uPSIxLjEiIHZpZXdCb3g9IjAgMCA4MDAgODAwIj4KICA8IS0tIEdlbmVyYXRvcjogQWRvYmUgSWxsdXN0cmF0b3IgMjkuNS4xLCBTVkcgRXhwb3J0IFBsdWctSW4gLiBTVkcgVmVyc2lvbjogMi4xLjAgQnVpbGQgMTQxKSAgLS0+CiAgPGRlZnM+CiAgICA8c3R5bGU+CiAgICAgIC5zdDAgewogICAgICAgIGZpbGw6ICNmZmY7CiAgICAgIH0KICAgIDwvc3R5bGU+CiAgPC9kZWZzPgogIDxwYXRoIGNsYXNzPSJzdDAiIGQ9Ik0zNzAuMSw2NzUuNmMxMDIuOC0xOC4yLDE4Ny43LTMzLjIsMTg4LjYtMzMuNGwxLjgtLjQtOTctMTE1LjRjLTUzLjQtNjMuNS05Ny0xMTUuNy05Ny0xMTYsMC0uNiwxMDAuMi0yNzYuNSwxMDAuOC0yNzcuNS4yLS4zLDY4LjQsMTE3LjQsMTY1LjMsMjg1LjQsOTAuNywxNTcuMywxNjUuNSwyODYuOSwxNjYuMiwyODguMWwxLjMsMi4yaC0zMDguNHMtMzA4LjQsMC0zMDguNCwwbDE4Ni45LTMzaDBaTTAsNjQwLjRjMC0uMiw0NS43LTc5LjUsMTAxLjYtMTc2LjRsMTAxLjYtMTc2LjEsMTE4LjQtOTkuNGM2NS4xLTU0LjcsMTE4LjYtOTkuNCwxMTguOC05OS41LjIsMC0uNiwyLjEtMS45LDQuOC0xLjMsMi43LTU5LjEsMTI2LjgtMTI4LjYsMjc1LjhsLTEyNi4zLDI3MC44aC05MS44QzQxLjMsNjQwLjcsMCw2NDAuNiwwLDY0MC40SDBaIi8+Cjwvc3ZnPg==&logoColor=white&labelColor=000000)]()

# Endpoint integration with Computer vision tags analyze

## cURL Placeholder

```sh
$ curl --location 'https://<RESOURCE_NAME_IN_AZURE>/vision/v3.2/read/analyze' \
--header 'Content-Type: application/json' \
--header 'Ocp-Apim-Subscription-Key: <AZURE_API_KEY>' \
--data '{
    "url": "<IMAGE_URL>"
}'
```
> [!NOTE]  
> We are going to get an empty body response with status code 202 (Accepted).
> We will get a response header and we need to take the callback url from "Operation-Location" attribute
> And using this one to get the result.

## Second call example

```sh
$ curl --location 'https://az204-computer-vision-ai.cognitiveservices.azure.com/vision/v3.2/read/analyzeResults/8a74c70c-3088-4a28-a53c-f7ace6c1eae0' \
--header 'Content-Type: application/json' \
--header 'Ocp-Apim-Subscription-Key: <AZURE_API_KEY>'
```

## Response body

```json
    {
    "status": "succeeded",
    "createdDateTime": "2026-11-20T20:30:21Z",
    "lastUpdatedDateTime": "2026-11-20T20:30:22Z",
    "analyzeResult": {
        "version": "3.2.0",
        "modelVersion": "2022-04-30",
        "readResults": [
            {
                "page": 1,
                "angle": -0.4896,
                "width": 1750,
                "height": 1178,
                "unit": "pixel",
                "lines": [
                    {
                        "boundingBox": [
                            80,
                            65,
                            1023,
                            64,
                            1024,
                            164,
                            80,
                            165
                        ],
                        "text": "Northwind Traders",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.972
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    80,
                                    71,
                                    609,
                                    64,
                                    607,
                                    165,
                                    81,
                                    165
                                ],
                                "text": "Northwind",
                                "confidence": 0.996
                            },
                            {
                                "boundingBox": [
                                    650,
                                    64,
                                    1024,
                                    65,
                                    1021,
                                    165,
                                    647,
                                    165
                                ],
                                "text": "Traders",
                                "confidence": 0.997
                            }
                        ]
                    },
                    {
                        "boundingBox": [
                            1601,
                            105,
                            1674,
                            62,
                            1695,
                            94,
                            1621,
                            138
                        ],
                        "text": "PIGE WINKER",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.972
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    1602,
                                    104,
                                    1622,
                                    93,
                                    1641,
                                    125,
                                    1621,
                                    137
                                ],
                                "text": "PIGE",
                                "confidence": 0.136
                            },
                            {
                                "boundingBox": [
                                    1628,
                                    89,
                                    1672,
                                    63,
                                    1692,
                                    95,
                                    1648,
                                    121
                                ],
                                "text": "WINKER",
                                "confidence": 0.116
                            }
                        ]
                    },
                    {
                        "boundingBox": [
                            78,
                            262,
                            476,
                            262,
                            475,
                            325,
                            78,
                            323
                        ],
                        "text": "Fresh produce,",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.972
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    79,
                                    262,
                                    215,
                                    262,
                                    213,
                                    323,
                                    78,
                                    322
                                ],
                                "text": "Fresh",
                                "confidence": 0.998
                            },
                            {
                                "boundingBox": [
                                    232,
                                    262,
                                    476,
                                    262,
                                    473,
                                    326,
                                    230,
                                    323
                                ],
                                "text": "produce,",
                                "confidence": 0.996
                            }
                        ]
                    },
                    {
                        "boundingBox": [
                            514,
                            211,
                            574,
                            204,
                            580,
                            266,
                            520,
                            272
                        ],
                        "text": "IS",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.945
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    514,
                                    210,
                                    560,
                                    205,
                                    567,
                                    267,
                                    520,
                                    272
                                ],
                                "text": "IS",
                                "confidence": 0.654
                            }
                        ]
                    },
                    {
                        "boundingBox": [
                            78,
                            340,
                            487,
                            337,
                            488,
                            402,
                            78,
                            406
                        ],
                        "text": "friendly service",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.972
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    80,
                                    340,
                                    278,
                                    340,
                                    277,
                                    406,
                                    78,
                                    406
                                ],
                                "text": "friendly",
                                "confidence": 0.996
                            },
                            {
                                "boundingBox": [
                                    291,
                                    340,
                                    487,
                                    337,
                                    487,
                                    403,
                                    291,
                                    406
                                ],
                                "text": "service",
                                "confidence": 0.997
                            }
                        ]
                    },
                    {
                        "boundingBox": [
                            1160,
                            1072,
                            1705,
                            1067,
                            1706,
                            1129,
                            1161,
                            1136
                        ],
                        "text": "Open 7 days a week",
                        "appearance": {
                            "style": {
                                "name": "other",
                                "confidence": 0.972
                            }
                        },
                        "words": [
                            {
                                "boundingBox": [
                                    1160,
                                    1074,
                                    1302,
                                    1071,
                                    1303,
                                    1136,
                                    1161,
                                    1137
                                ],
                                "text": "Open",
                                "confidence": 0.989
                            },
                            {
                                "boundingBox": [
                                    1320,
                                    1071,
                                    1354,
                                    1070,
                                    1355,
                                    1135,
                                    1321,
                                    1135
                                ],
                                "text": "7",
                                "confidence": 0.996
                            },
                            {
                                "boundingBox": [
                                    1366,
                                    1070,
                                    1493,
                                    1068,
                                    1494,
                                    1133,
                                    1368,
                                    1135
                                ],
                                "text": "days",
                                "confidence": 0.989
                            },
                            {
                                "boundingBox": [
                                    1506,
                                    1068,
                                    1540,
                                    1068,
                                    1541,
                                    1133,
                                    1507,
                                    1133
                                ],
                                "text": "a",
                                "confidence": 0.998
                            },
                            {
                                "boundingBox": [
                                    1552,
                                    1068,
                                    1703,
                                    1067,
                                    1705,
                                    1131,
                                    1554,
                                    1133
                                ],
                                "text": "week",
                                "confidence": 0.991
                            }
                        ]
                    }
                ]
            }
        ]
    }
}
```