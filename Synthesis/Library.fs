module Synthesis

let abelar a = (a > 12 && a < 3097 && a % 12 = 0)
    //failwith "Not implemented"
    

let area b h = 
    match b >= 0.00 && h >= 0.00 with
    |true -> b * h / 2.00
    |_ ->  failwith "Not implemented"
   

let zollo pos =
    match pos < 0 with
    |true -> pos * -1
    |_ ->
    match pos >= 0 with
    |true -> pos * 2
    |_ ->
    failwith "Not implemented"

let min a b =
  match a < b || b > a with
    |true -> a
    |_ ->
    match b < a || a > b with
    |true -> b
    |_ ->
    match a = b with
    |true -> a
    |_ ->
    failwith "Not implemented"

let max a b =
    match a > b || b < a with
    |true -> a
    |_ ->
    match b > a || a < b with
    |true -> b
    |_ ->
    match a = b with
    |true -> a
    |_ ->
    failwith "Not implemented"

let ofTime h m s =
    match h>=0 && m >= 0 && s >= 0 with
    |true -> (h * 60 * 60) + (m * 60) + s
    |_ -> 
    failwith "Not implemented"

let toTime sec =
    let h = sec / 3600
    let m = (sec / 60) % 60
    let s = (sec - (h * 3600)) % 60
    match sec <= 0 with 
    |true -> (0,0,0)
    |_ -> (h, m, s)
//failwith "Not implemented"

let digits input =
    let rec count num acc=
        match num / 10 = 0 with
            |true -> acc
            |_ -> count (num / 10) (acc + 1)
    count input 1
//failwith "Not implemented"

   

let minmax (a,b,c,d) =
    let x = min(min a b) (min c d) 
    let y = max(max a b) (max c d)
    x, y
failwith "Not implemented"

let isLeap leap =   match leap < 1582 with
                    |true -> failwith "Not implemented"
                    |false ->   match (leap % 4 = 0 && not(leap % 100 = 0)) ||  (leap % 4 = 0 && leap % 400 = 0)  with
                                |true -> true
                                |false -> false

let month monthday =    match monthday < 1 || monthday > 12 with
                        |true -> failwith "Not implemented"
                        |false ->   match monthday with  
                                    |1 -> "January", 31 
                                    |2 -> "February", 28
                                    |3 -> "March", 31 
                                    |4 -> "April", 30 
                                    |5 -> "May", 31 
                                    |6 -> "June", 30
                                    |7 -> "July", 31 
                                    |8 -> "August", 31
                                    |9 -> "September", 30 
                                    |10 -> "October", 31 
                                    |11 -> "November", 30
                                    |12 -> "December", 31 
        


let toBinary dec =
     match dec < 0 with
     |true -> failwith "Not Implemented"
     |false ->  let rec dectobin deci acc =
                 match deci = 0 with 
                 |true ->  
                    match acc with 
                    |"" -> "0"
                    |_ -> acc
                 |false ->
                    let rem = deci % 2
                    match rem = 0 with
                    |true -> dectobin(deci / 2) ("0" + acc)
                    |false -> dectobin(deci / 2) ("1" + acc)
                dectobin dec ""


    
    //failwith "Not implemented"
let bizFuzz x =
    let rec count a b c d =
        match a>x || x<0 with
        |true -> (b,c,d)
        |false ->   match (a%3=0 && a%5=0) with
                    |true -> count (1+a) (1+b) (1+c) (1+d)
                    |false ->   match a%3=0 with
                                |true -> count (1+a) (1+b) (c) (d)
                                |false ->   match a%5=0 with
                                            |true -> count (1+a) (b) (1+c) (d)
                                            |false -> count (1+a) b c d
    match x<0 with
    |true -> (0,0,0)
    |false -> count 1 0 0 0



let monthDay d y =
    match d < 1 || d > 367 || y < 1582 with
    |true -> failwith "Not Implemented"
    |false ->   
        let result = (d /30) + 1
        match d < 30 with
        |true -> "January"
        |_->    match (isLeap(y)= false) with
                | true  ->
                    let b,c = month ((d/30) + 1)
                    b
                | false-> 
                             let m, r = month((d % 30) + 1)
                             m 
     //failwith "Not implemented"  

let coord _ =
    failwith "Not implemented"