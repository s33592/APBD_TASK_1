# APBD\_TASK\_1



# CalculateAverage(int[] values)

The function enables the user to calculate the average of an
array of integer values.

# CalculateMax(int[] values)

The function enables the user to find the maximum value in an array 
of integer values

# CalculateMin(int[] values)

The function enables the user to find the minimum value in an array
of integer values 

# When does Git perform a fast-forward and when is a merge commit created?

Git performs a fast-forward when the branch that we merge into hasn't changed in any way 
from the point when the new branch was created. In this case, Git can just move the branch
pointer to the tip of the other branch. A merge commit, on the other hand, is created when 
both branches have advanced independently in their commit histories, so Git creates a merge
commit to join them.

# What is the practical difference between merge and rebase?

A merge combines histories from both branches preserving their timelines.In contrast, 
rebase deletes the old commits with new ones, so to look like you have started work from
the latest commit of the other branch, resulting in a cleaner, linear history.

# How was the conflict resolved in your repository?

The conflict in my repository was resolved by firstly comparing both versions of the code
from both branches and picking the one which was "better" (as described in the merge commit).
Then, I staged and commited the source code file (Project/Program.cs). A merge commit was successfully
created, and finally, the changes were pushed to the remote repository on Github.

