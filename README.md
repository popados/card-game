<div id="top-of-doc"></div>

# Readme File |

[My Github](https://github.com/popados) | [Jump to End](#end-of-doc)

---

---

### DayNum | x/x/20xx - Today

```
could nest my if statements here
    - each creature is summoned > summonedSickness
    - ability function?? could over ride an empty ability
    - want it to go like this player sel > card > field > ability > attack > end
    - have sel > card > field > attack > end
    - each card can have an ability that checks field area
    - i.e fire drake gains +1/+1 atk/hp if (card.cardName = fire draco)
            //
```

most of these need to rely on the card triggering the effect
could check field and if > creature && has effect

enum each type maybe to make an easy property to read for the card

- creature damage[x]
- spell damage[x]
- aura[] -
  - spell damage doesnt work
- call[] -
  - additional summon from hand
- defender[] -
  - blocker
- first strike[] -
  - only attack creature && if summoned = true
- force[] -
  - return creature card to hand
- hyper[] -
  - creature ignores summoning sickness
- last will[] -
  - effect trigger in graveyard
- mute[] -
  - removes effects of creature
- overkill[] -
  - defender destroyed deals damage to its hp
- overpower[] -
  - destroy defenders immediately
- rally[] -
  - additional summon from deck
- ressurect[] -
  - happen from graveyard
- ritual[] -
  - play cost to do effect
- unstoppable[] -
  - can attack directly

---

[Jump to Top](#top-of-doc)

<div id="end-of-doc"></div>

<details>
## Notes :
</details>
