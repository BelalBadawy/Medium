import React, { useState } from "react";
import useData from "../../hooks/useData";
import { LoaderSpinner } from "./LoaderSpinner";

export const PostCategories = () => {
  let size = 3;

  const [displayCount, setDisplayCount] = useState(size);

  const { data, loading, error } = useData(
    "/Categories/ListWithPostCount"
  );



  return (
    <aside className="widget widget_categories">
      <div className="widget-title">Categories</div>
      <ul>
        {loading && <LoaderSpinner />}
        {error &&
          <li >
            {error}
          </li>
        }
        {data &&

          data.slice(0, displayCount).map((cat) => (
            <li key={cat.id}>
              <a href="#">{cat.title} </a> ({cat.postCounts})
            </li>
          ))


        }
        {data && data.length > displayCount &&
          <li onClick={() => { setDisplayCount(displayCount + size) }} style={{ cursor: 'pointer' }}>
            <i className="icofont-plus"></i>
          </li>
        }
      </ul>
    </aside>
  );
};
