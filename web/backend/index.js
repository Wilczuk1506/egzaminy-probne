const express = require("express");
const cors = require('cors');

const app = express();

app.use(cors())
app.use(express.json())

app.get('/', (req, res) => {
    res.sendStatus(200);
});

app.listen(8000, () => {console.log("server status")});

