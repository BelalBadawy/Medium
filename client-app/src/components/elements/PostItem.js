import React from "react";
import { Link } from "react-router-dom";

export const PostItem = (props) => {
  const options = {
    year: "numeric",
    month: "long",
    day: "numeric",
  };

  const { id, userId, userName, slug, title, description, bannerImageUrl, viewCount, createdDate, postCommentsCount, postTags, postCategories } = props.post;

  return (
    <article className="post" key={id}>
      <div className="post-preview">
        <Link to={`/postdetails/:id/:slug`}>
          <img
            src={bannerImageUrl}
            alt={title}
            className="img-fluid rounded"
          />
        </Link>
      </div>

      <div className="post-header">
        <h2 className="post-title">
          <a href="blog-single.html">{title}</a>
        </h2>
        <ul className="post-meta">
          <li>
            <i className="icofont-ui-calendar"></i>{" "}
            {new Date(createdDate).toLocaleString("en-US", options)}{" "}

          </li>

          {postTags && (
            <li>
              <i className="icofont-tags"></i>{" "}
              {postTags.map((tag, index) => (<a href="#" key={tag}>{tag}{(index < postTags.length - 1) ? ", " : ""}</a>))}
            </li>
          )}

          <li>
            <i className="icofont-comment"></i>{" "}
            <a href="#">{postCommentsCount} Comments</a>
          </li>
        </ul>
      </div>

      <div className="post-content">
        <p>{description}</p>
      </div>

      <div className="post-more">
        <a href="#">
          Read More <i className="mdi mdi-arrow-right"></i>
        </a>
      </div>
    </article>
  );
};
