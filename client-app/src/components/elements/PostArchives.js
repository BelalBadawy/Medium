import React, { useState } from "react";
import useData from "../../hooks/useData";
import { LoaderSpinner } from "./LoaderSpinner";

export const PostArchives = () => {
  const year = new Date().getFullYear();

  const { data, loading, error } = useData(
    "/Posts/PostsArchives?year=" + year
  );


  return (
    <aside className="widget">
      <div className="widget-title">Archives</div>
      <ul>
        {loading && <LoaderSpinner />}
        {error}
        {data &&
          data.map((arch) => (
            <li key={arch.id}>
              <a href="#">{arch.monthYearName}</a> ({arch.postCounts})
            </li>
          ))}
      </ul>
    </aside>
  );
};
