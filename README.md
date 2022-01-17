# PoskodMYAPI

End Points (GET Method)
 - /api/Poskod/MaklumatPoskod/{poskod}
      result example : {
      "poskod": "41000",
      "bandar": "Klang",
      "negeri": "Selangor",
      "negara": "Malaysia"
    }
    
 - /api/Poskod/SenaraiMaklumatPoskod/{poskod}
      result example : {
    "poskod": "41000",
    "bandar": "Klang",
    "negeri": "Selangor",
    "negara": "Malaysia",
    "senaraiMaklumatPoskod": [
      "Jalan Stesyen 1",
      "Jalan Sulam",
      "Jalan Sultan",
      "Jalan Sungai Jati",
      "Jalan Sutera",
      "Jalan Bentara",
      "Jalan Besar",
      "Jalan Bukit Badak",
      "Jalan Bukit Jati",
      "Jalan Bukit Jawa",
    ]
  }
  
 - /api/Poskod/SenaraiPoskodNegeri/{negeri}
      result example : {
    "negeri": "Selangor",
    "jumlah": 282,
    "senaraiPoskodKawasan": [
      {
        "poskod": "26060",
        "bandar": "Kuantan"
      },
      {
        "poskod": "27000",
        "bandar": "Jerantut"
      },
      {
        "poskod": "40000",
        "bandar": "Shah Alam"
      },
      {
        "poskod": "40100",
        "bandar": "Shah Alam"
      }
    ]
   }
 
 - /api/Poskod/SenaraiPoskodNegeri/{negeri}
        result example : {
      "bandar": "Shah Alam",
      "negeri": "Selangor",
      "jumlah": 80,
      "senaraiPoskod": [
        "40000",
        "40592",
        "40503",
        "40626",
        "40608",
        "40598",
        "40716",
        "40548",
       ]
     }
