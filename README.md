# Inspection States Model (ism)

Repo Contains a simple Model of Inspection State Transitions

## Goal
 - Decouple temporary UI States from Store States.
 - State Representation of Transitions betweens UI States.
 - Easily Change Transition types.
    - e.g. **fade transition** to **flyover transition**.

## References and Useful Links

### Useful for dealing Layouts.
- [State Management and Layout](https://www.pluralsight.com/guides/ui-state-management-with-redux-in-angular-4)
- [UI State Machine](https://www.cognitect.com/blog/2017/5/22/restate-your-ui-using-state-machines-to-simplify-user-interface-development)

### Modeling using Union/Sum Types.
- [Visitor Pattern](https://www.hurtak.cc/union-types/)
- [Visitor as Sum Type](https://blog.ploeh.dk/2018/06/25/visitor-as-a-sum-type/)
- [UI Modeling State with TS](https://www.azavea.com/blog/2019/12/12/modeling-state-with-typescript/)
- [FSM CSS](https://css-tricks.com/robust-react-user-interfaces-with-finite-state-machines/)

### Though written in elm, defining animations and action gives a few hints.
- [Elm's perspective](https://korban.net/posts/elm/2020-04-07-using-elm-animator-with-elm-ui/)

### NGRX. Local State or Disposable

- [ngrx component](https://ngrx.io/guide/component)
- [ngrx component store](https://ngrx.io/guide/component-store)

### Animation References
- [Fly Over animation](https://jsfiddle.net/n109rpp0/4/)
