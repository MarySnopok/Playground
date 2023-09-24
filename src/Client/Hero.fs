namespace Client

open Fable.React
open Fable.React.Props
open Elmish
open Fable.Remoting.Client
open Fable.React.Standard
open Shared
open Fable.React
open Fable.React.Props


module Hero =
    let hero =
        div [ Class "hero" ] [
            img [
                Src ""
                Alt "Hero img"
            ]
        ]