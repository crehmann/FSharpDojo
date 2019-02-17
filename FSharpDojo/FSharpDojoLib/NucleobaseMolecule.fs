module NucleobaseMolecule
open System

[<Struct>]
type NucleobaseMolecule = private NucleobaseMolecule of char

let create (character : char)=
    match Char.ToUpper character with
    | 'A' -> Ok (NucleobaseMolecule 'A')
    | 'C' -> Ok (NucleobaseMolecule 'C')
    | 'G' -> Ok (NucleobaseMolecule 'G')
    | 'T' -> Ok (NucleobaseMolecule 'T')
    | _ -> Error("Unknown nucleobase molecule")
     