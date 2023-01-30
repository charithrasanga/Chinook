
## Developer Note

### Move data retrieval methods to separate class / classes (use dependency injection)

You will find a Directory named " Repositories" Which includes
1. Generic repository implementation ( simple but effective)
2. Repository Wrapper( for easy access of the data)
3. Related Repositories that extend Generic Repository 

Dependency injection example can  be found in Program.cs file. please note that UserPlaylistRepository has been extended form it's interface as well as generic repository. you may find both Lambda expressions and Raw Sql statement exececution via entity framework due to the limited time.

### Favorite / unfavorite tracks. An automatic playlist should be created named "My favorite tracks"
Done
### The user's playlists should be listed in the left navbar. If a playlist is added (or modified), this should reflect in the left navbar. There is already one playlist link in the Nav Menu as an example.
Done

### Add tracks to a playlist (existing or new one). The dialog is already created but not yet finished.
Done

### The user should be able to remove tracks from the playlist.
Done 
### User should be able to rename the playlist
Done ( need to refresh the page to see the effect)
### User should be able to remove the whole playlist
Done  ( need to refresh the page to see the effect)
### Search for artist name
Done

## Special Note

Thanks for allowing me to participate in this assignment. I did enjoy working on it. however, it took me more than  3 hours to complete as I was working on and off due to Other pressing matters. I hope it won't be a problem.

You may find simple architecture as I wanted to stay minimal and not to over-engineer things. however, I belive that are certain areas that  can improve and introduce well defined, clean and extendable abstraction between UI and Business logic.
 
