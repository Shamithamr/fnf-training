const createCsvWriter = require("csv-writer").createObjectCsvWriter;
const csvWriter = createCsvWriter({
    path:'result.csv',
    header:[
        {id:'name',title:'Name'},
        {id:'email',title:'Email'},
        {id:'phone',title:'Phone'},
        {id:'address',title:'Address'}
    ]
})

const details = [
    {name:'jhon',email:'johm@gmail.com',phone:'987654334',address:'mysore'},
    {name:'harshi',email:'harshi@gmail.com',phone:'887654334',address:'udupi'}
];

csvWriter.writeRecords(details).then(()=> {console.log('Csv file is created');});