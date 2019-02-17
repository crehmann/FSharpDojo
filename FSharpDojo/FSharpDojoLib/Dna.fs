namespace FSharpDojo
open Utils

module Dna =
    
    let countNucleotidesInDna dna =
        dna
        |> Seq.map (fun (c) -> NucleobaseMolecule.create c)
        |> Seq.filter isResultOk
        |> countById
        |> Seq.map (fun (kv) -> kv.Value.ToString())
        |> String.concat " "