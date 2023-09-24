namespace Client

open Fable.React
open Fable.React.Props
open Elmish
open Fable.Remoting.Client
open Fable.React.Standard
open Shared
open Fable.React
open Fable.React.Props

module Logo =
    let logo =
        div [ Class "logo" ] [
            a [ Href ""
                Target "blank"
                Rel "noopener"
            ] [
                img [
                        Src ""
                        Alt "custom company logo image"
                    ]

            ]
        ]