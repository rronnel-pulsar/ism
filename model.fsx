(*

    version 2.

    # Changes
        - Remove Card State.

    # Assumption
        - Transition States are simillar between swimlanes.
        - Generalized Transition for any action.
*)

type Inspection = {
    id: string
    name: string
}

// TODO. unhappy path cases.
type BasicTransitionState =
    | Idle
    | Loading
    | Loaded

type FadingTransitionState =
    | Idle
    | Loading
    | Loaded
    | FadingIn
    | FadingOut

type FlyingTransitionState =
    | Idle
    | Loading
    | Flying
    | Loaded

type CardTransitionType =
    | None
    | Basic of BasicTransitionState
    | Fading of FadingTransitionState
    | Flying of FlyingTransitionState

//type CardState =
//    | Idle
//    | Loading
//    | Loaded

type Card = {
    cardId: string
    inspectionId: string // single unique reference to annotations.
    //cardState: CardState
    transitionType: CardTransitionType
 }

type SwimlaneName =
    | Annotating
    | Review
    | Done

type Swimlane = {
    name: SwimlaneName
    items: Card list
}

type Board = Swimlane list

let card = {
    cardId= "1"
    inspectionId= "1"
    transitionType= Fading FadingTransitionState.Loading
}
