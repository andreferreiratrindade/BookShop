#!/bin/bash

# Prompt user for old and new text
read -p "Enter the text to replace: " old
read -p "Enter the new text: " new

echo "Renaming all files and folders from '$old' to '$new'..."

# Find and rename recursively
find . -depth -name "*$old*" | while read item; do
    new_item=$(echo "$item" | sed "s/$old/$new/g")
    echo "Renaming: $item → $new_item"
    mv "$item" "$new_item"
done

echo "Renaming completed."