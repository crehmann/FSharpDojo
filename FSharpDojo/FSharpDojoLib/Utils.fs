module Utils
open System

let countById dna =
    let counts = Collections.Generic.Dictionary<_,_>()
    for molecule in dna do
        match counts.TryGetValue molecule with
        | false, _ -> counts.[molecule] <- 1L
        | true, c -> counts.[molecule] <- c + 1L
    counts

let isResultOk result =
    match result with
    |Ok _ -> true
    |Error _ -> false
