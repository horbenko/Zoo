# ZooConsole

This console application simulates the life of animals in the zoo. In the zoo can live lions, tigers, elephants, bears, wolfs and foxes. Each animal has following characteristics: nickname, health (a lion - 5 points, a tiger - 4 points, an elephant - 7 points, a bear - 6 points, a wolf - 4 points, a fox - 3 points), condition (well-fed, hungry, sick, dead).
The program expects commands from user: 
- Add the animal. Needed to input nickname and animal species. The animal will have faded condition after adding.
- Feed the animal.  Needed to input nickname of the animal you want to feed.
- Cure the animal. Need to input nickname of the animal you want to cure. This command increases the health of the chosen animal by 1 point.
 - Remove the animal. Need to input nickname of the animal you want to remove. An only dead animal can be removed from the zoo.
For each command displayed the result.

Every 5 seconds in the zoo changes the condition of one animal. The life flow of animals have next order: Well-fed-> Hungry -> Sick. If the animal was in a state of sickness, then take one point of health.

When health point is 0, the animal goes to the dead condition. If all animals in the zoo are dead, displayed a message and program finished its work.
