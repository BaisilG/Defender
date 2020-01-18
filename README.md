# Defender

Defensive code should be easy, and it shouldn't weigh your code down.

Wait, do we really need yet another guard clause library?

Unfortunantly yes. There's a number of problems with existing ones. Without naming names, partially not to stir up problems, and partially because there's just so damn many of them, this is going to be descriptive of the overall guard clause library climate, not any individual one. Still, there is no single library I've seen that meets all the required criteria.

That is until now.

#### Clauses should work for everything with the appropriate semantics
	
This seems like it would be straightforward, but it's not. Consider variants of `NotNull()` which enforce that an argument is not null. Simple, right? You just make sure any reference type isn't null. Only it's [not that simple](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types).

#### Clauses shouldn't work for anything with inappropriate semantics

This one, again, seems very straightforward. It's not though. I've seen cases of making the `NotNull()` variant work for any `Object`. The problem with this is twofold. One, it boxes value types which hurts performance. Two, it always returns a specific value for a non-nullable value type, and in that instance it shouldn't even be called, because that hurts performance. Ideally, the API won't even let you call guards when the result is already known.

#### Clauses shouldn't weigh down code

Obviously, right? And keeping in the tradition of cargo-cult and "I don't need evidence, just trust me" based programming this generally isn't the case. There's a disturbingly large number of guard clause libraries which claim to be anything from "lightweight" to "high performance" and yet are noticably slower than manual guards. This isn't acceptable.

#### Clauses should be easy to quick to type

This is a very niche library type. The point is to get guards out of the way as quickly as possible, to encourage their use. Less keystrokes to implement means theoretically more use of the guards. And yet many of these have very long clauses, due to the use of fluent API's.

Now don't get me wrong. I love fluent API's. Most of what I write has a fluent API. But like any tool, it's useful for certain tasks and only those tasks. This is not the place for a fluent API. This is the place for a simple procedural API.

#### Clauses should not allocate

As obvious as this should seem, it's disturbingly not the case. Overwhelmingly guard-clause libraries implement fluent API's which by their very nature allocate. If these allocations are already happening anyways, that's fine. But adding allocations is unacceptable. Even as lightweight as a `ref struct` is, that's still a high performance impact for something as trivial as a guard clause.