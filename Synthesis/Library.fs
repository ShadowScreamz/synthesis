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
     let h = sec % 3600
     let hh = h * 60
     let m = hh % 60
     let mm = m * 60
     let s = sec - hh - mm
     //sec = (h, m ,s )
     failwith "Not implemented"

let digits input =
    let rec count num =
        match num >= - 9 || num <= 9 with
        |true -> 1
        |_ -> 
            match num / 10 >= 0 with
            |true -> 1 + count(num + 1)
            |_ -> 
            failwith "Not implemented"
    count input
   

let minmax _ =
    failwith "Not implemented"

let isLeap _ =
    failwith "Not implemented"

let month _ =
    failwith "Not implemented"

let toBinary _ =
    failwith "Not implemented"

let bizFuzz _ =
    failwith "Not implemented"

let monthDay _ _ =
    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"