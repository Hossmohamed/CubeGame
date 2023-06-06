const express = require('express');

const stripe = require('stripe')("sk_test_51N96sVGXyzvXCyS2agvuwkd397mWCVdR1pYPC80TBiZxbip9tfX4hAPkzbKoVpAALMRTYb4Vqu4RDfv4kHjuWNRs00EjZSKVks");

const bodyparser = require('body-parser');

const cors = require('cors');

const app = express()

app.use(bodyparser.urlencoded({extended:false}))

app.use(bodyparser.json())

app.use(cors())

app.post('/checkout', async (req, res) => {
    // console.log(req.body)

    try{
        // token = req.body.token;
        token = req.body.token;
        console.log(req.body);
        const customer = stripe.customers
        .create({
            email: "yasmeenahmed4488@gmail.com",
            source: token.id,
        })
        .then((customer) => {
            // console.log(customer);
            return stripe.charges.create({
                amount : 1000,
                description : "A Simple Snake Game !!!!!!!!!!",
                currency: "USD",
                customer: customer.id,
            });
        })
        .then((charge) =>{
            // console.log(charge);
            res.json({
                data : "success",
            });
        })
        .catch((err) => {
            res.json({
                data : "failure",
            });
        });
        return true;
    }
    catch(error){
        return false;
    }
})

app.listen(5000, () => {
    console.log("App is Listening on port 5000")
})