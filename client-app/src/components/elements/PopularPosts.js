import React, { useState } from "react";
import useData from "../../hooks/useData";
import { LoaderSpinner } from "./LoaderSpinner";

export const PopularPosts = () => {
  const { data, loading, error } = useData(
    "/Posts/PopularPosts?postCounts=3"
  );
  // const options = {
  //   weekday: "long",
  //   year: "numeric",
  //   month: "long",
  //   day: "numeric",
  // };

  const options = {
    year: "numeric",
    month: "long",
    day: "numeric",
  };

  return (
    <aside className="widget widget_recent_entries_custom">
      <div className="widget-title">Popular Posts</div>
      <ul>
        {loading && <LoaderSpinner />}
        {data &&
          data.map((post) => (
            <li className="clearfix" key={post.id}>
              <div className="wi">
                <a href="#">
                  <img src={post.bannerImageUrl} alt="" className="img-fluid" />
                </a>
              </div>
              <div className="wb">
                <a href={post.slug}>{post.title}</a>{" "}
                <span className="post-date">
                  {new Date(post.createdDate).toLocaleString("en-US", options)}{" "}
                </span>
              </div>
            </li>
          ))}
      </ul>
    </aside>
  );
};
