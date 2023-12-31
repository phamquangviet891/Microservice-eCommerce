const maxTitleLength = 49;

const trimmedTitle = (title) => {
  return title.length > maxTitleLength
    ? title.substring(0, maxTitleLength) + "..."
    : title;
};

export default trimmedTitle;
