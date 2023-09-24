namespace Client

open Elmish
open Elmish.React
open Fable.Core.JsInterop

module App =

    //importSideEffects "./global.sass"
    //importAll"flatpickr/dist/themes/material_green.css"

    #if DEBUG
    open Elmish.Debug
    open Elmish.HMR
    #endif

    Program.mkProgram Index.init Index.update Index.view
    #if DEBUG
    |> Program.withConsoleTrace
    #endif
    |> Program.withReactSynchronous "elmish-app"  //|> Program.withReactHydrate "elmish-app"  
    #if DEBUG
    |> Program.withDebugger
    #endif
    |> Program.run